﻿using SentimentAnalysisTool.Data.Models;
using SentimentAnalysisTool.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Services.Implementations
{
    public class CorpusTypeService : ICorpusTypeService
    {
        private readonly HttpClient _httpClient;
        public CorpusTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Apikey", "MyUltimateSecretKeyNYAHAHAHAHAHAHAHA");
        }
        public async Task<bool> AddCorpusTypeAsync(CorpusTypeModel corpusType, string baseUrl)
        {
            var response = await _httpClient.PostAsJsonAsync<CorpusTypeModel>($"{baseUrl}/api/CorpusType", corpusType);
            var responseCode = response.EnsureSuccessStatusCode();

            if (responseCode.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<IEnumerable<CorpusTypeModel>> FetchCorpusTypesAsync(string baseUrl)
        {
            var response = await _httpClient.GetAsync($"{baseUrl}/api/CorpusType");
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return await response.Content.ReadAsAsync<IEnumerable<CorpusTypeModel>>();

            return new List<CorpusTypeModel>();
        }
    }
}
