﻿/**
* author:xishuai
* address:https://www.github.com/yuezhongxin/MessageManager
**/

using System;

namespace MessageManager.Domain.DomainModel
{
    public class User : IAggregateRoot
    {
        public User(string loginName, string displayName)
        {
            if (string.IsNullOrEmpty(loginName))
            {
                throw new ArgumentException("loginName can't be null");
            }
            if (string.IsNullOrEmpty(displayName))
            {
                throw new ArgumentException("displayName can't be null");
            }
            this.ID = Guid.NewGuid().ToString();
            this.LoginName = loginName;
            this.DisplayName = displayName;
        }

        public string ID { get; set; }
        public string LoginName { get; set; }
        public string DisplayName { get; set; }
    }
}
