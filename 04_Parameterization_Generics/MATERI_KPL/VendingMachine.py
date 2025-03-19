import time  # Untuk jeda waktu (delay)

class VendingMachine:
    def __init__(self):
        self.state = 'Idle'
        self.product_selected = None
        
        # Daftar produk
        self.products = {
            'A1': 'Coca-Cola',
            'A2': 'Sprite',
            'A3': 'Fanta'
        }

        # Transisi FSM
        self.transitions = {
            'Idle': {
                'Masukkan Uang': 'MenungguProduk'
            },
            'MenungguProduk': {
                'Pilih Produk': 'MengeluarkanProduk',
                'Reset': 'Idle'
            },
            'MengeluarkanProduk': {
                'Keluarkan Produk': 'Selesai'
            },
            'Selesai': {
                'Reset': 'Idle'
            }
        }

    # Fungsi untuk menampilkan animasi loading
    def loading(self, message, duration=2):
        print(message, end="")
        for _ in range(duration):
            time.sleep(0.5)
            print(".", end="", flush=True)
        print()

    # Fungsi untuk meminta persetujuan pengguna
    def confirm_action(self, message):
        while True:
            response = input(f"{message} (y/n): ").strip().lower()
            if response == 'y':
                return True
            elif response == 'n':
                print("❌ Aksi dibatalkan.")
                return False
            else:
                print("⚠️ Input tidak valid. Harap masukkan 'y' atau 'n'.")

    # Fungsi untuk melakukan transisi state
    def on_event(self, event, product_code=None):
        if event in self.transitions[self.state]:
            # Persetujuan pengguna sebelum melanjutkan
            if not self.confirm_action(f"Apakah Anda yakin ingin melanjutkan ke langkah '{event}'?"):
                return  # Jika tidak disetujui, batalkan langkah tersebut

            if self.state == 'MenungguProduk' and event == 'Pilih Produk':
                if product_code in self.products:
                    self.product_selected = self.products[product_code]
                    self.loading(f"Memproses pilihan {self.product_selected}")
                else:
                    print(f"❌ Produk dengan kode '{product_code}' tidak tersedia.")
                    return
            
            self.state = self.transitions[self.state][event]
            self.loading(f"Transisi ke state: {self.state}")

            if self.state == 'MengeluarkanProduk':
                self.loading(f"Mengeluarkan {self.product_selected}")
            
            if self.state == 'Selesai':
                print(f"✅ Terima kasih telah berbelanja! Silakan ambil {self.product_selected}.")
        else:
            print(f"❌ Event '{event}' tidak valid pada state '{self.state}'")

# Simulasi Mesin Penjual Otomatis
def main():
    vm = VendingMachine()

    # Daftar event untuk simulasi
    events = [
        ('Masukkan Uang', None),
        ('Pilih Produk', 'A1'),
        ('Keluarkan Produk', None),
        ('Reset', None)
    ]

    print(f"🟢 State awal: {vm.state}\n")
    for event, product_code in events:
        vm.on_event(event, product_code)

if __name__ == "__main__":
    main()
