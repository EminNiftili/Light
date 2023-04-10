using AutoMapper;
using Light.Data.DataAccess;
using Light.Data.Entity;
using Light.Data.Entity.Implementation;
using Light.Logic.DataTransferObjects.OneC;
using Light.Logic.Enums;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Light.Logic.Services.Implementation
{
    public class OneCService : IOneCService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OneCService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void OneCDataGenerate(OneCDto oneC, bool forceUpdate = false)
        {
            if (!forceUpdate) 
            {
                #region withour forceUpdate
                //var addedProducts = oneC.Products.Where(x => x.DataStatus == DataStatus.Added).ToList();
                //var changedProducts = oneC.Products.Where(x => x.DataStatus == DataStatus.Changed).ToList();

                //var addedBranches = oneC.Branches.Where(x => x.DataStatus == DataStatus.Added).ToList();
                //var changedBranches = oneC.Products.Where(x => x.DataStatus == DataStatus.Changed).ToList();

                //var addedCustomers = oneC.Customers.Where(x => x.DataStatus == DataStatus.Added).ToList();
                //var changedCustomers = oneC.Customers.Where(x => x.DataStatus == DataStatus.Changed).ToList();

                //var addedProductBranches = oneC.ProductBranches.Where(x => x.DataStatus == DataStatus.Added).ToList();
                //var changedProductBranches = oneC.ProductBranches.Where(x => x.DataStatus == DataStatus.Changed).ToList();

                //var products = _mapper.Map<List<Product>>(addedProducts);
                //var branches = _mapper.Map<List<Branch>>(addedBranches);
                //var customers = _mapper.Map<List<Customer>>(addedCustomers);
                //var productBranches = _mapper.Map<List<ProductBranch>>(addedProductBranches);

                //_unitOfWork.Product.AddRange(products);
                //_unitOfWork.Commit();

                //_unitOfWork.Branch.AddRange(branches);
                //_unitOfWork.Commit();

                //_unitOfWork.Customer.AddRange(customers);
                //_unitOfWork.Commit();

                //_unitOfWork.ProductBranch.AddRange(productBranches);
                //_unitOfWork.Commit();

                //products = null;
                //branches = null;
                //customers = null;
                //productBranches = null;

                //products = _mapper.Map<List<Product>>(changedProducts);
                //branches = _mapper.Map<List<Branch>>(changedBranches);
                //customers = _mapper.Map<List<Customer>>(changedCustomers);
                //productBranches = _mapper.Map<List<ProductBranch>>(changedProductBranches);

                //foreach(var product in products)
                //{
                //    product.OneCId = product.Id;
                //    var id = _unitOfWork.Product.GetEntity(product.Id, "OneCId").Id;
                //    product.Id = id;
                //    _unitOfWork.Product.Update(product);
                //}
                //foreach (var branch in branches)
                //{
                //    branch.OneCId = branch.Id;
                //    var id = _unitOfWork.Branch.GetEntity(branch.Id, "OneCId").Id;
                //    branch.Id = id;
                //    _unitOfWork.Branch.Update(branch);
                //}
                //foreach (var customer in customers)
                //{
                //    var id = _unitOfWork.Customer.GetEntity(customer.Barcode, "OneCId").Id;
                //    product.Id = id;
                //    _unitOfWork.Product.Update(product);
                //}
                //foreach (var product in products)
                //{
                //    product.OneCId = product.Id;
                //    var id = _unitOfWork.Product.GetEntity(product.Id, "OneCId").Id;
                //    product.Id = id;
                //    _unitOfWork.Product.Update(product);
                //}
                #endregion
            }
            else
            {
                _unitOfWork.StoredProcedure.Exec(Procedures.ClearSqlForAddFromOneC);


                var products = _mapper.Map<List<Product>>(oneC.Products);
                var branches = _mapper.Map<List<Branch>>(oneC.Branches);
                var customers = _mapper.Map<List<Customer>>(oneC.Customers);
                var productBranches = _mapper.Map<List<ProductBranch>>(oneC.ProductBranches);

                _unitOfWork.GetRepository<Product>().AddRange(products);
                _unitOfWork.Commit();

                _unitOfWork.GetRepository<Branch>().AddRange(branches);
                _unitOfWork.Commit();

                _unitOfWork.GetRepository<Customer>().AddRange(customers);
                _unitOfWork.Commit();

                _unitOfWork.GetRepository<ProductBranch>().AddRange(productBranches);
                _unitOfWork.Commit();
            }


        }
    }
}
