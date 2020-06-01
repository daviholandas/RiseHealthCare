using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RiseHealth.WebApi.ViewModels.Management;
using RiseHealthCare.Domain.Management;
using RiseHealthCare.Domain.Management.ValueObjects;
using RiseHealthCare.Domain.Shared.ValueObjects;

namespace RiseHealth.WebApi.Setup.AutoMapper
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            //Common
            CreateMap<Phone, PhoneViewModel>();

            //Management
            CreateMap<Professional, ProfessionalBasicViewModel>();
            CreateMap<Procedure, ProcedureViewModel>();
            CreateMap<Council, CouncilViewModel>();

        }
    }
}
