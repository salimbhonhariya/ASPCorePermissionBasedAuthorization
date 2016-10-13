using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationLab
{
    public class PermissionsAuthorizationRequirement : IAuthorizationRequirement
    {
        public IEnumerable<Permission> RequiredPermission { get; }

        public PermissionsAuthorizationRequirement(IEnumerable<Permission> requiredPermissions)
        {
            RequiredPermission = requiredPermissions;
        }
    }
    //Permission is an enum, and this allows me to pass a list of them as the requirement1. Hopefully it’s apparent how this is more flexible than a instance-per-effective-permission would be, let alone class-per-effective-permission.
    //public class Permission
    //{
    //    public static OperationAuthorizationRequirement Create =
    //        new OperationAuthorizationRequirement { Name = "ToCreate" };
    //    public static OperationAuthorizationRequirement Read =
    //        new OperationAuthorizationRequirement { Name = "ToRead" };
    //    public static OperationAuthorizationRequirement Update =
    //        new OperationAuthorizationRequirement { Name = "ToUpdate" };
    //    public static OperationAuthorizationRequirement Delete =
    //        new OperationAuthorizationRequirement { Name = "ToDelete" };
    //}

    public enum Permission
    {
      Insert,
      Update,
      Delete,
      Select,
    }
}
