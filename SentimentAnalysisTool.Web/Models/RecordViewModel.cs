﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web.Models
{
    public class RecordViewModel
    {
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public int PositivePercent { get; set; }
        public int NegativePercent { get; set; }
        public IEnumerable<CommentVaderViewModel> CommentViewModels { get; set; }
        public IEnumerable<CorpusRecordViewModel> CorpusRecordViewModels { get; set; }
        public IEnumerable<WordFrequencyViewModel> WordFrequencyViewModels { get; set; }
        public IEnumerable<CorpusTypeViewModel> CorpusTypeViewModels { get; set; }
    }
}
