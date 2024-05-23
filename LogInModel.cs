using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuickShoap.Models
{
    public class LogInModel
    {
        /// <summary>
        /// Get or Sets strPassword value
        /// </summary>
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        [StringLength(50)]
        public string strPassword { get; set; }

        /// <summary>
        /// Gets or sets the StrEmail value.
        /// </summary>
       
        public string strCompanyCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StrEmail value.
        /// </summary>
        [Required(ErrorMessage = "*")]
        public string strLoginName
        {
            get;
            set;
        }
    }
}