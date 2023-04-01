using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        void DeleteBreakfast(Guid id);
        ErrorOr<Breakfast> GetBreakfast(Guid id);
        void UpsertBreakfast(Breakfast breakfast);
    }
}