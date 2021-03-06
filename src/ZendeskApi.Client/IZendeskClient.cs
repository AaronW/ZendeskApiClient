﻿using ZendeskApi.Client.Resources;

namespace ZendeskApi.Client
{
    public interface IZendeskClient
    {
        IRequestResource Requests { get; }
        ITicketResource Tickets { get; }
        ITicketCommentResource TicketComments { get; }
        IOrganizationResource Organizations { get; }
        ISearchResource Search { get; }
        IGroupResource Groups { get; }
        IAssignableGroupResource AssignableGroups { get; }
        IUserResource Users { get; }
        IUserIdentityResource UserIdentities { get; }
        IOrganizationMembershipResource OrganizationMemberships { get; }
    }
}