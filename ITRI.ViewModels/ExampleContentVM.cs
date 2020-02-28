using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace ITRI.ViewModels
{
    public class ExampleContentVM
    {
        // other properties omitted
        public int ExamId { get; set; }
        public string[] TxtExample { get; set; }
        public IFormFile[] VoiceExample { get; set; }
        public IFormFile[] PicExample { get; set; }
        public string[] TxtA { get; set; }
        public string[] TxtB { get; set; }
        public string[] TxtC { get; set; }
        public string[] TxtD { get; set; }
        public string[] TxtE { get; set; }
        public string[] TxtF { get; set; }
        public int[] Answer { get; set; }
        public IFormFile[] PicA { get; set; }
        public IFormFile[] PicB { get; set; }
        public IFormFile[] PicC { get; set; }
        public IFormFile[] VoiceA { get; set; }
        public IFormFile[] VoiceB { get; set; }
        public IFormFile[] VoiceC { get; set; }

        public int GroupId { get; set; }
        public int AccountId { get; set; }
        public int? Level { get; set; }
        public int? Category { get; set; }
        public int? Reference { get; set; }
        public string Volume { get; set; }
        public string Class { get; set; }
        public int? Theme { get; set; }
        public string Number { get; set; }
        public string Proposition { get; set; }

        public string TxtExampleGroup { get; set; }
        public IFormFile PicExampleGroup { get; set; }
        public IFormFile VoiceExampleGroup { get; set; }

        public string PicExampleGroupMark { get; set; }
        public string VoiceExampleGroupMark { get; set; }

        public string[] VoiceExampleMark { get; set; }
        public string[] PicExampleMark { get; set; }
        public string[] PicAmark { get; set; }
        public string[] PicBmark { get; set; }
        public string[] PicCmark { get; set; }
        public string[] VoiceAmark { get; set; }
        public string[] VoiceBmark { get; set; }
        public string[] VoiceCmark { get; set; }
    }
}
