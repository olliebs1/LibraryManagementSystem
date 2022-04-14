using System;
using System.Collections.Generic;

namespace LibraryManagement.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}
