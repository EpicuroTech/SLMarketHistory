﻿
using SplinterlandsMarketTrack.Network;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

internal static class UtilsHelpers
{
    public static string GenerateHtmlTable(List<LineOnRent> history)
    {
        var html = new StringBuilder();
        html.AppendLine("<html>");
        html.AppendLine("<head>");
        html.AppendLine("<title>Rental History</title>");
        html.AppendLine("</head>");
        html.AppendLine("<body>");
        html.AppendLine("<table border='1'>");

        // Add table header
        html.AppendLine("<tr>");
        html.AppendLine("<th>Id</th><th>Rent Transaction ID</th><th>Card ID</th><th>Rental Price</th>" +
            "<th>Total Pay</th><th>Number of Days</th><th>Rental Start Date</th><th>Rental Next Payment</th>");
        // ... Add headers for other properties as well
        html.AppendLine("</tr>");

        // Add table rows
        foreach (var item in history)
        {
            html.AppendLine("<tr>");
            html.AppendLine($"<td>{item.id}</td><td>{item.sell_trx_id}</td><td>{item.card_id}</td><td>{item.buy_price}</td>" +
                $"<td>{item.payment_amount}</td><td>{item.rental_days}</td><td>{item.rental_date.ToString("yyyy-MM-dd")}</td>" +
                $"<td>{item.next_rental_payment.ToString("yyyy-MM-dd")}</td>");
            // ... Add other properties as table data
            html.AppendLine("</tr>");
        }

        html.AppendLine("</table>");
        html.AppendLine("</body>");
        html.AppendLine("</html>");

        return html.ToString();
    }

    public static List<LineOnRent> GetAllRentHistory(string player)
    {
        var myHistory = new List<LineOnRent>();
        var aux = new List<LineOnRent>();
        int offset;
        ApiClient apiClient = new ApiClient();

        for (int skip = 0; skip<2800; skip += 200)
        {
            offset = skip + 200;
            aux = apiClient.GetRentalHistory(player, skip, offset);
            myHistory.AddRange(aux);
        }
        return myHistory;
    }


    public static decimal MonthTotalRent(List<LineOnRent> myHistory)
    {
        decimal totalRent = 0;
        DateTime currentDate = DateTime.Now;
        DateTime dateThirtyDaysAgo = currentDate.Subtract(TimeSpan.FromDays(30));
        decimal amount;

        foreach (var lineOnRent in myHistory)
        {
            // se foi arrendada à mais de 30 dias e continua a ser arrendada
            if (lineOnRent.rental_date < dateThirtyDaysAgo && lineOnRent.next_rental_payment >= currentDate)
            {
                //decimal.TryParse(lineOnRent.paid_amount, NumberStyles.Any, CultureInfo.InvariantCulture, out amount);
                amount = decimal.Parse(lineOnRent.buy_price, NumberStyles.Any, CultureInfo.InvariantCulture);
                totalRent += amount * 30;
            }


            // se foi arrendada à mais de 30 dias e terminou em algum momento durante os ultimos 30 dias
            else if (lineOnRent.rental_date < dateThirtyDaysAgo && lineOnRent.next_rental_payment > dateThirtyDaysAgo)
            {
                amount = decimal.Parse(lineOnRent.buy_price, NumberStyles.Any, CultureInfo.InvariantCulture);

                TimeSpan daysRented = lineOnRent.next_rental_payment - lineOnRent.rental_date;
                int totalDaysRented = (int)daysRented.TotalDays;
                totalRent += amount * totalDaysRented;
            }

            // restantes durante os ultimos 30 dias
            else if (lineOnRent.rental_date >= dateThirtyDaysAgo)
            {
                amount = decimal.Parse(lineOnRent.paid_amount, NumberStyles.Any, CultureInfo.InvariantCulture);
                totalRent += amount;
            }
        }

        return totalRent;
    }

}