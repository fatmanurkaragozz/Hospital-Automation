using System;
using System.Collections.Generic;
using HospitalAutomation.Models;

namespace HospitalAutomation.Interfaces
{
    // Branş servisinin temel metodlarını tanımlayan arayüz
    public interface IBransService
    {
        // Yeni bir branş ekler
        bool AddBranch(Brans branch);

        // Var olan bir branşı günceller
        bool UpdateBranch(Brans branch);

        // Bir branşı siler
        bool DeleteBranch(int branchId);

        // Tüm branşları alır
        List<Brans> GetAllBranches();

        // Belirli bir branşı id'sine göre alır
        Brans GetBranchById(int branchId);
    }
}
