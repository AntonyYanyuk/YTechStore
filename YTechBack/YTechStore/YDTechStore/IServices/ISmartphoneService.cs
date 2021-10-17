using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTechStore.Models;

namespace YTechStore.IServices
{
    public interface ISmartphoneService
    {
        Smartphone Save(Smartphone smartphone);
    }
}
