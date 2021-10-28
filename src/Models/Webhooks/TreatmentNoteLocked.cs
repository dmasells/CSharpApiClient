using System;
using System.Collections.Generic;
using System.Text;

namespace IntakeQ.ApiClient.Models.Webhooks
{
    public class TreatmentNoteLocked
    {
        public string NoteId { get; set; }
        public string Type { get; set; }
        public int ClientId { get; set; }
    }
}
