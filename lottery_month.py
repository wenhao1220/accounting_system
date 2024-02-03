import requests
from bs4 import BeautifulSoup
import pymysql

url = "https://invoice.etax.nat.gov.tw/"
response = requests.get(url)
soup = BeautifulSoup(response.content, "html.parser")

# Find the element containing the current redemption year and month
redemption_info = soup.find("a", {"class": "etw-on"})

if redemption_info is None:
    print("Could not find redemption information on the website.")
else:
    # Extract the year and month range from the element's text
    redemption_text1 = redemption_info.text
    redemption_year1 = redemption_text1[:3]
    redemption_month_range1 = redemption_text1[4:9]

    print(redemption_year1)
    print(redemption_month_range1)

    connection = pymysql.connect(
        host="database123.mysql.database.azure.com",
        user="wen_hao",
        password="Myjane00!",
        database="test4",
    )

    cursor = connection.cursor()

    cursor.execute("UPDATE this_month_numbers SET year=%s, month=%s", (redemption_year1, redemption_month_range1))

    connection.commit()

    connection.close()


# Get redemption information from the second website
url2 = "https://invoice.etax.nat.gov.tw/lastNumber.html"
response2 = requests.get(url2)
soup2 = BeautifulSoup(response2.content, "html.parser")

# Find the element containing the current redemption year and month
redemption_info2 = soup2.find("a", {"class": "etw-on"})

if redemption_info2 is None:
    print("Could not find redemption information on the website.")
else:
    # Extract the year and month range from the element's text
    redemption_text2 = redemption_info2.text
    redemption_year2 = redemption_text2[:3]
    redemption_month_range2 = redemption_text2[4:9]

    print(redemption_year2)
    print(redemption_month_range2)

    connection = pymysql.connect(
        host="database123.mysql.database.azure.com",
        user="wen_hao",
        password="Myjane00!",
        database="test4",
    )

    cursor = connection.cursor()

    cursor.execute("UPDATE last_month_numbers SET year=%s, month=%s", (redemption_year2, redemption_month_range2))

    connection.commit()

    connection.close()