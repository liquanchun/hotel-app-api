using System;
using System.Collections.Generic;

namespace Hotel.App.Model.SYS
{
    public class sys_user : IEntityBase
    {
        public sys_user()
        {
            RoleUserList = new List<sys_role_user>();
        }
        public int Id { get; set; }
        /// <summary>
        /// user_id
        /// </summary>		
        public string UserId { get; set; }
        /// <summary>
        /// user_name
        /// </summary>		
        public string UserName { get; set; }
        /// <summary>
        /// mobile
        /// </summary>		
        public string Mobile { get; set; }
        /// <summary>
        /// weixin
        /// </summary>		
        public string Weixin { get; set; }
        /// <summary>
        /// email
        /// </summary>		
        public string Email { get; set; }
        /// <summary>
        /// pwd
        /// </summary>		
        public string Pwd { get; set; }
        /// <summary>
        /// last_login_time
        /// </summary>		
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// org_id
        /// </summary>		
        public int OrgId { get; set; }
        /// <summary>
        /// updatedAt
        /// </summary>		
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// createdAt
        /// </summary>		
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// isvalid
        /// </summary>		
        public bool IsValid { get; set; }

        public string RoleIds { get; set; }

        public ICollection<sys_role_user> RoleUserList { get; set; }

        public sys_org Org;
    }
}

