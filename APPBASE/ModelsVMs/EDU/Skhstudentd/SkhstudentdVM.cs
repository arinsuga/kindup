﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class SkhstudentdlistVM
    {
        public int? ID { get; set; }
        public string EVALUATION_DESC { get; set; }
        public string RATE_CODE { get; set; }
        public string RATE_DESC { get; set; }
    } //End public partial class SkhstudentdlistVM
    public partial class SkhstudentddetailVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? STUDENTSKH_ID { get; set; }
        public int? EVALUATION_ID { get; set; }
        public int? RATE_ID { get; set; }
        public string EVALUATION_CODE { get; set; }
        public string EVALUATION_DESC { get; set; }
        public string RATE_CODE { get; set; }
        public string RATE_DESC { get; set; }
    } //End public partial class SkhstudentddetailVM

    public partial class SkhstudentdlookupVM
    {
        public int? ID { get; set; }
    } //End public partial class SkhstudentdlistVM

} //End namespace APPBASE.Models
