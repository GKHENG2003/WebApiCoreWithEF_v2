namespace LibraryManagementSystemEF.Entities.Contract
{
    internal interface ISoftDeletable
    {
        public bool IsDeleted { get; set; }

    }
}
