//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAssignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Moviestable
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        [DisplayFormat(DataFormatString ="{0:D}",ApplyFormatInEditMode =false)]
        public Nullable<System.DateTime> movie_dor { get; set; }
    }
}