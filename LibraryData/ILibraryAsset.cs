using System;
using System.Collections;
using System.Collections.Generic;
using LibraryData.Models;

namespace LibraryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int id);
        void Add(LibraryAsset newAsset);
        string GetAuthorOrDirector(int id);
        string GetDewetIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        string GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);

    }
}
