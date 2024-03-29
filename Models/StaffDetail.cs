//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentStaffApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class StaffDetail
    {
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Name Field is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use Alphabets only please")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender Field is Required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "City Cannot be Empty")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use Alphabets only please")]
        public string City { get; set; }
        [Required(ErrorMessage = "Experience Cannot be Empty")]
        public Nullable<int> Experience { get; set; }
        [Required(ErrorMessage = "PhoneNumber Cannot be Empty")]
        [RegularExpression(@"^\(?([6-9]{1})\)?([0-9]{9})$", ErrorMessage = "phone number must starts with 9|8|7|6.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Salary Cannot be Empty")]
        public Nullable<long> Salary { get; set; }
        [Required(ErrorMessage = "Subject Cannot be Empty")]
        public string subject { get; set; }
    }
}
