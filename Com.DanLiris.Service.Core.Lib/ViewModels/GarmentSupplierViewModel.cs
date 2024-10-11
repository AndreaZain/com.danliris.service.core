using Com.DanLiris.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Core.Lib.ViewModels
{
    public class GarmentSupplierViewModel : BasicViewModel
	{
		public string code { get; set; }

		public string name { get; set; }

		public string address { get; set; }

		public string contact { get; set; }

		public string country { get; set; }

		public string PIC { get; set; }

		/* Bool */
		public dynamic import { get; set; }
		public dynamic usevat { get; set; }
		public string NPWP { get; set; }

		public string serialNumber { get; set; }

		public dynamic usetax { get; set; }

		public IncomeTaxViewModel IncomeTaxes { get; set; }

		public bool IsPosted { get; set; }

		public string description { get; set; }

        public List<string> DocumentsFile { get; set; }
        public List<string> DocumentsPath { get; set; }
        public List<string> DocumentsFileName { get; set; }
    }
}
