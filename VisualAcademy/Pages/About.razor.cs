using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class About
    {
        public string Title { get; set; } = "정보";
        public string SubTitle { get; set; } = "부제목";

        protected override void OnInitialized()
        {
            SubTitle = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}