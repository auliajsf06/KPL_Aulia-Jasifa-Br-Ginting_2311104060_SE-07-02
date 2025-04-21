import os
from dotenv import load_dotenv

load_dotenv()

def get_base_url():
    return os.getenv("BASE_URL")

# Pastikan python-dotenv sudah terinstall
# Anda bisa mengistallnya dengan perintah berikut:
# pip install python-dotenv