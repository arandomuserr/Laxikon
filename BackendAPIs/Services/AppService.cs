using BackendAPIs.DataModels;
using BackendAPIs.Models.RequestsAndResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBackend.Services
{
    public class AppService : IAppService
    {
        private LaxikonContext _laxikon;

        public AppService(LaxikonContext laxikonContext)
        {
            _laxikon = laxikonContext;
        }

        #region GetSignupInfo

        public SignUpApiResponseModel GetSignupInfo(string email)
        {
            List<SignUpInfo> signuInfoList = new List<SignUpInfo>();
            SignUpApiResponseModel signUpApiResponse = new SignUpApiResponseModel();
            try
            {
                signuInfoList = _laxikon.SignUpInfo.Where(x => x.EmailAddress == email).ToList();
                if (signuInfoList != null && signuInfoList.Count > 0)
                {
                    signUpApiResponse.Password = signuInfoList.FirstOrDefault().Password;
                    signUpApiResponse.Status = true;
                }
            }
            catch (Exception ex)
            {
            }
            return signUpApiResponse;
        }

        #endregion GetSignupInfo

        #region GetAllProducts

        public List<ProductDetails> GetAllProducts()
        {
            List<Products> productsList = new List<Products>();
            List<ProductDetails> productDetailsList = new List<ProductDetails>();

            try
            {
                productsList = _laxikon.Products.ToList();

                if (productsList != null && productsList.Count > 0)
                {
                    foreach (var product in productsList)
                    {
                        ProductDetails productDetail = new ProductDetails();
                        productDetail.Id = product.Id;
                        productDetail.SalePrice = product.SalePrice;
                        productDetail.RegularPrice = product.RegularPrice;
                        productDetail.WeightInKgs = product.Weight;
                        productDetail.Category = product.Category;
                        productDetail.Size = product.Size;
                        productDetail.Color = product.Color;
                        productDetail.ImageURl = product.ImageURl.Split(", ");

                        productDetailsList.Add(productDetail);
                    }
                }
            }
            catch (Exception e)
            {
            }

            return productDetailsList;
        }

        #endregion GetAllProducts

        #region InsertSignupInfo

        public int InsertSignupInfoIntoDatabase(InsertSignupInfoParams insertSignupInfoParams)
        {
            SignUpInfo signUpInfo = new SignUpInfo();

            signUpInfo.EmailAddress = insertSignupInfoParams.EmailAddress;
            signUpInfo.Password = insertSignupInfoParams.Password;
            signUpInfo.Phone = insertSignupInfoParams.Phone;
            signUpInfo.Name = insertSignupInfoParams.Name;
            signUpInfo.Address = insertSignupInfoParams.Address;

            _laxikon.SignUpInfo.Add(signUpInfo);

            _laxikon.SaveChanges();

            return signUpInfo.Id;
        }

        #endregion InsertSignupInfo
    }
}