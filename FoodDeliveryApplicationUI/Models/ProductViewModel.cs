﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodDeliveryApplicationUI.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Required (ErrorMessage ="Enter Product Id:")]
        public int  ProductQuantity { get; set; }
        [Required(ErrorMessage = "Product Name is required:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required:")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required:")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        // Additional properties as needed for the view

        [Display(Name = "Product Image:")]
        public HttpPostedFileBase ImageFile { get; set; }

        // Image file name (to store the file name in the database)
        public string ImageFileName { get; set; }

        [Required(ErrorMessage = "Category is required:")]
        [Display(Name = "Product Category:")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } // Dropdown list items for categories
    }

}