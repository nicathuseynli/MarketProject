using AutoMapper;
using MarketProject.Datas.Entities;
using MarketProject.Dtos.CategoryDtos;
using MarketProject.Dtos.EmployeeDtos;
using MarketProject.Dtos.PartnerCompanyDtos;
using MarketProject.Dtos.ProductDtos;

namespace MarketProject.Mappers;
public class MappingProfile:Profile
{
    public MappingProfile()
    {
      //GetMapp
      CreateMap<Category,CreateCategoryDto>();
      CreateMap<PartnerCompany, CreatePartnerCompanyDto>();
      CreateMap<Product, CreateProductDto>();
      CreateMap<Employee,CreateEmployeeDto>();
      //CreateMapp
      CreateMap<Category, CreateCategoryDto>().ReverseMap();
      CreateMap<PartnerCompany, CreatePartnerCompanyDto>().ReverseMap();
      CreateMap<Product, CreateProductDto>().ReverseMap();
      CreateMap<Employee,CreateEmployeeDto>().ReverseMap();
     //UpdateMapp
      CreateMap<Category, UpdateCategoryDto>().ReverseMap();
      CreateMap<PartnerCompany, UpdatePartnerCompanyDto>().ReverseMap();
      CreateMap<Product, UpdateProductDto>().ReverseMap();
      CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();
    }
}
