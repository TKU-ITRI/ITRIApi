using System.Collections.Generic;
using ITRI.Models.Entities;
using ITRI.ViewModels;
using Newtonsoft.Json.Linq;

namespace ITRI.Services.Interface
{
    public interface IITRIViewS
    {
        DatatablesVM<ViewsTableVM> GetAll(int start, int length);
       
    }
}
