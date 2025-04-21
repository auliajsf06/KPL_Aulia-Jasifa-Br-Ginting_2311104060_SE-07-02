# Pilih salah satu konfigurasi
# from config_json import get_base_url
from config_env import get_base_url

import requests # type: ignore

def main():
    base_url = get_base_url()
    try:
        response = requests.get(f"{base_url}/status")
        if response.status_code == 200:
            print("API aktif:", response.json())
        else:
            print("Gagal:", response.status_code)
    except Exception as e:
        print("Koneksi gagal:", e)

if __name__ == "__main__":
    main() 