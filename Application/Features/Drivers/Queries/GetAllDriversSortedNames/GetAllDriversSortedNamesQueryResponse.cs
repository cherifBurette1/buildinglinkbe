﻿namespace Application.Features.Drivers.Queries.GetAllDriversSortedNames
{
    public class GetAllDriversSortedNamesQueryResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}