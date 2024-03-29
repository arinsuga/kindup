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
    public partial class SkmVM : FilterdataVM
    {
        public List<SkmlistitemVM> LIST { get; set; }
        public SkmdetailVM DETAIL { get; set; }
    } //End public partial class SkmlistVM

    public partial class SkmlistitemVM
    {
        public int? YEAR_ID { get; set; }
        public Byte? SEMESTER_ID { get; set; }
        public Byte? CLASSTYPE_ID { get; set; }
        public Byte? WEEKNUM { get; set; }
        public DateTime? DATEFROM { get; set; }

        public int? ID { get; set; }
        public string EVALUATION_DESC { get; set; }
    } //End public partial class SkmlistVM
    public partial class SkmdetailVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? YEAR_ID { get; set; }
        public Byte? SEMESTER_ID { get; set; }
        public Byte? CLASSTYPE_ID { get; set; }
        public Byte? WEEKNUM { get; set; }
        public DateTime? DATEFROM { get; set; }
        public DateTime? DATETO { get; set; }
        public int? EVALUATION_ID { get; set; }
        public string SKM_DESC { get; set; }
        public string YEAR_DESC { get; set; }
        public DateTime? YEAR_FROM { get; set; }
        public DateTime? YEAR_TO { get; set; }
        public string SEMESTER_DESC { get; set; }
        public Byte? SEMESTER_NUM { get; set; }
        public string CLASSTYPE_NAME { get; set; }
        public string CLASSTYPE_DESC { get; set; }
        public string EVALUATION_CODE { get; set; }
        public string EVALUATION_DESC { get; set; }
    } //End public partial class SkmdetailVM

    public partial class SkmlookupVM
    {
        public int? ID { get; set; }
        public string EVALUATION_DESC { get; set; }
    } //End public partial class SkmlistVM

} //End namespace APPBASE.Models
