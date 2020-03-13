
private DataTable GetUnpaidExpenseList(string pDriver)
		{
			// ErrorLog
			WebServiceException.WriteError("getUnpaidExpenseList inside the function()");

			var dtReturn = new DataTable("UnpaidExpenses");

			dtReturn.Columns.Add("ExpenseID", typeof(string));
			dtReturn.Columns.Add("DriverID", typeof(string));
			dtReturn.Columns.Add("ItemDate", typeof(string));
}
