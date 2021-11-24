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
    public class CorpusRecordService : ICorpusRecordService
    {
        public async Task<bool> AddCorpusRecordAsync(CorpusRecordModel corpus, string baseUrl, HttpClient httpClient)
        {
            var response = await httpClient.PostAsJsonAsync<CorpusRecordModel>($"{baseUrl}/api/CorpusRecords", corpus);
            var responseCode = response.IsSuccessStatusCode;

            if (responseCode)
                return true;

            return false;
        }
    }
}