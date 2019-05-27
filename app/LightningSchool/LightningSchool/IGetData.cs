using System;
using System.Threading.Tasks;

namespace LightningSchool
{
    public interface IGetData
    {
        Task<string> GetApiData(string endpoint);
    }
}
