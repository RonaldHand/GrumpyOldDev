﻿using Serenity.Navigation;
using Organization = GrumpyOldDev.Organization.Pages;

[assembly: NavigationMenu(8000, "Organization", icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Business Units", typeof(Organization.BusinessUnitController), icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Contacts", typeof(Organization.ContactController), icon: "fa-address-book")]