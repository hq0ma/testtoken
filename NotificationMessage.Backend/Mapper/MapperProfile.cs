using AutoMapper;
using NotificationMessage.Backend.Model;
using NotificationMessage.Backend.Service.MessageHistoryDto;
using NotificationMessage.Backend.Service.ProjectDto;
using NotificationMessage.Backend.Service.UserDtos;
using NotificationMessage.Backend.Service.WalletUserDto;

namespace NotificationMessage.Backend.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Create Merchant profile
            CreateMap<User, AllUserDto>();
            CreateMap<AllUserDto, User>();

            CreateMap<User, AddUserDto>();
            CreateMap<AddUserDto, User>();

            CreateMap<User, UpdateUserDto>();
            CreateMap<UpdateUserDto, User>();

            // Create Project profile
            CreateMap<Project, AllProjectDto>();
            CreateMap<AllProjectDto, Project>();

            CreateMap<Project, AddProjectDto>();
            CreateMap<AddProjectDto, Project>();

            CreateMap<Project, UpdateProjectDto>();
            CreateMap<UpdateProjectDto, Project>();

            // Create Message profile
            CreateMap<MessageHistory, AllMessageDto>();
            CreateMap<AllMessageDto, MessageHistory>();

            CreateMap<MessageHistory, AddMessageDto>();
            CreateMap<AddMessageDto, MessageHistory>();

            CreateMap<MessageHistory, UpdateMessageDto>();
            CreateMap<UpdateMessageDto, MessageHistory>();

            // Create Wallet profile
            CreateMap<WalletUser, AllWalletDto>();
            CreateMap<AllWalletDto, WalletUser>();

            CreateMap<WalletUser, AddWalletDto>();
            CreateMap<AddWalletDto, WalletUser>();

            CreateMap<WalletUser, UpdateWalletDto>();
            CreateMap<UpdateWalletDto, WalletUser>();

            // Create Transction profile
            CreateMap<Transction, TransctionDto>();
            CreateMap<TransctionDto, Transction>();

            CreateMap<Transction, AddTransctionDto>();
            CreateMap<AddTransctionDto, Transction>();

            CreateMap<Transction, UpdateTransctionDto>();
            CreateMap<UpdateTransctionDto, Transction>();
        }
    }
}
