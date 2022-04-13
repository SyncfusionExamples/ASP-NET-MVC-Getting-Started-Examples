using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Localization_with_dynamic_culture.Models
{
    public class CultureDetails
    {
        public string ID { get; set; }
        public string Text { get; set; }

        public List<CultureDetails> Cultures()
        {
            List<CultureDetails> Culture = new List<CultureDetails>();
            Culture.Add(new CultureDetails() { ID = "en-US", Text = "English" });
            Culture.Add(new CultureDetails() { ID = "de", Text = "Germany" });
            Culture.Add(new CultureDetails() { ID = "fr", Text = "French" });
            Culture.Add(new CultureDetails() { ID = "zh", Text = "Chinese" });
            return Culture;
        }
    }
}