using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMServices.Mappers {
	public class MappingProfile:Profile {
	public MappingProfile() {
			CreateMap<Models.UserRequestModel, FMData.Entity.User>().ReverseMap();
		}

	}
}
