def boi_tinh_duyen(ten_nam , ten_nu):
    ten_nam = ten_nam.lower()
    ten_nu = ten_nu.lower()
    
    dem = 0 
    
    for chu_cai in range(ord('a'),ord('z')+1):
        if (chr(chu_cai) in ten_nam) and  (chr(chu_cai) in ten_nu) : 
            dem = dem + 1
    
    if dem == 0:
        ket_qua = "Binh thuong"
    elif dem < 3 : 
        ket_qua = "Friend zone"
    else : 
        ket_qua = "Hop nhau"
    return ket_qua

print("Nhap ten nam : ")
ten_nam = input()
print("Nhap ten nu : ")
ten_nu = input()

print("Kết qua của " + ten_nam + " và " + ten_nu + " la : " + boi_tinh_duyen(ten_nam,ten_nu))