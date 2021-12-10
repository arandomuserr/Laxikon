using BackendAPIs.DataModels;
using BackendAPIs.Models.RequestsAndResponses;
using System.Collections.Generic;

namespace AppBackend
{
    public interface IAppService
    {
        public SignUpApiResponseModel GetSignupInfo(string email);

        public List<ProductDetails> GetAllProducts();

        public int InsertSignupInfoIntoDatabase(InsertSignupInfoParams insertSignupInfoParams);
    }
}