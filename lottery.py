import requests
from bs4 import BeautifulSoup
import pymysql

url = "https://invoice.etax.nat.gov.tw/"

try:
    response = requests.get(url)
except requests.exceptions.ConnectionError:
    print("Error: Could not access website.")
    exit()

if response.status_code == 200:
    soup = BeautifulSoup(response.content, "html.parser")

    numbers = []

    for row in soup.find_all("span", class_="font-weight-bold"):
        numbers.append(row.text)

    final_numbers = numbers[:8]
    print(final_numbers)

connection = pymysql.connect(
    host="database123.mysql.database.azure.com",
    user="wen_hao",
    password="Myjane00!",
    database="test4",
)

cursor = connection.cursor()

# Truncate the table before inserting new values
cursor.execute("TRUNCATE TABLE this_month_numbers")

for number in final_numbers:
    cursor.execute("INSERT INTO this_month_numbers (numbers) VALUES (%s)", number,)

connection.commit()

connection.close()

#url2

url2 = "https://invoice.etax.nat.gov.tw/lastNumber.html"

try:
    response = requests.get(url2)
except requests.exceptions.ConnectionError:
    print("Error: Could not access website.")
    exit()

if response.status_code == 200:
    soup = BeautifulSoup(response.content, "html.parser")

    numbers = []

    for row in soup.find_all("span", class_="font-weight-bold"):
        numbers.append(row.text)

    final_numbers = numbers[:8]
    print(final_numbers)

# Connect to the MySQL database


connection = pymysql.connect(
    host="database123.mysql.database.azure.com",
    user="wen_hao",
    password="Myjane00!",
    database="test4",
)

cursor = connection.cursor()

# Truncate the table before inserting new values
cursor.execute("TRUNCATE TABLE last_month_numbers")

for number in final_numbers:
    cursor.execute("INSERT INTO last_month_numbers (numbers) VALUES (%s)", number,)

connection.commit()

connection.close()