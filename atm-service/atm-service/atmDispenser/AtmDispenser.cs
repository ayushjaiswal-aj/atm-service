namespace atm_service.atm_dispenser
{
	public class AtmDispenser
	{
		public AtmDispenser() { }

		public static List<string> getAmountDenomination(int amountToDispense)
		{
			List<string> amountDenominations = new List<string>();
			int remainingAmount = amountToDispense;
			int currancy500 = remainingAmount / 500;
			remainingAmount = remainingAmount % 500;

			int currancy200 = remainingAmount / 200;
			remainingAmount = remainingAmount % 200;

			int currancy100 = remainingAmount / 100;
			remainingAmount = remainingAmount % 100;

			int currancy50 = remainingAmount / 50;
			remainingAmount = remainingAmount % 50;

			if(remainingAmount == 0)
			{
				amountDenominations.Add($"Dispensing {currancy500} INR500 Note");
				amountDenominations.Add($"Dispensing {currancy200} INR200 Note");
				amountDenominations.Add($"Dispensing {currancy100} INR100 Note");
				amountDenominations.Add($"Dispensing {currancy50} INR50 Note");
            }
			else
			{
				amountDenominations.Add($"Error: Cannot Dispense ammount INR{amountToDispense}.");
			}

			return amountDenominations;
		}
	}
}

