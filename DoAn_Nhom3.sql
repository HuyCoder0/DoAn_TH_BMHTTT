create user nguyentruongduy_DOAN identified by 123;

grant create session to nguyentruongduy_DOAN

grant create table to nguyentruongduy_DOAN

ALTER USER nguyentruongduy_DOAN quota 200M on users


-- T?o b?ng SANPHAM
CREATE TABLE SANPHAM (
    ID_SANPHAM NUMBER PRIMARY KEY,
    TENSANPHAM NVARCHAR2(255),
    SOLUONG NUMBER,
    GIA NUMBER(18, 2),
    KHUYENMAI NUMBER(5, 2),
    TRANGTHAI NVARCHAR2(50)
);

-- T?o b?ng NHANVIEN
CREATE TABLE NHANVIEN (
    ID_NHANVIEN NUMBER PRIMARY KEY,
    TENNHANVIEN NVARCHAR2(255),
    CHUCVU NVARCHAR2(100),
    SDT NVARCHAR2(15),
    CCCD NVARCHAR2(12),
    NGAYSINH DATE,
    DIACHI NVARCHAR2(255),
    MATKHAU NVARCHAR2(100),
    LUONG NUMBER(18, 2),
    HESOLUONG NUMBER(5, 2),
    TRANGTHAI NVARCHAR2(50)
);

-- T?o b?ng KHACHHANG
CREATE TABLE KHACHHANG (
    ID_KHACHHANG NUMBER PRIMARY KEY,
    TENKHACHHANG NVARCHAR2(255),
    NGAYSINH DATE,
    DIACHI NVARCHAR2(255),
    SDT NVARCHAR2(15)
);

-- T?o b?ng HOADON
CREATE TABLE HOADON (
    ID_HOADON NUMBER PRIMARY KEY,
    NGAYLAP DATE,
    TONGTIEN NUMBER(18, 2),
    GIAMGIA NUMBER(5, 2),
    ID_NHANVIEN NUMBER,
    ID_KHACHHANG NUMBER,
    CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (ID_NHANVIEN) REFERENCES NHANVIEN(ID_NHANVIEN),
    CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (ID_KHACHHANG) REFERENCES KHACHHANG(ID_KHACHHANG)
);

-- T?o b?ng CHITIETHOADON
CREATE TABLE CHITIETHOADON (
    ID_CHITIETHOADON NUMBER PRIMARY KEY,
    TENSANPHAM NVARCHAR2(255),
    SOLUONG NUMBER,
    DONGIA NUMBER(18, 2),
    KHUYENMAI NUMBER(5, 2),
    THANHTIEN NUMBER(18, 2),
    ID_HOADON NUMBER,
    ID_SANPHAM NUMBER,
    CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY (ID_HOADON) REFERENCES HOADON(ID_HOADON),
    CONSTRAINT FK_CHITIETHOADON_SANPHAM FOREIGN KEY (ID_SANPHAM) REFERENCES SANPHAM(ID_SANPHAM)
);

-- T?o b?ng PHIEUNHAP
CREATE TABLE PHIEUNHAP (
    ID_PHIEUNHAP NUMBER PRIMARY KEY,
    NGAYLAPPHIEU DATE,
    NHACUNGCAP NVARCHAR2(255),
    TONGTIEN NUMBER(18, 2),
    ID_NHANVIEN NUMBER,
    CONSTRAINT FK_PHIEUNHAP_NHANVIEN FOREIGN KEY (ID_NHANVIEN) REFERENCES NHANVIEN(ID_NHANVIEN)
);

-- T?o b?ng CHITIETPHIEUNHAP
CREATE TABLE CHITIETPHIEUNHAP (
    ID_CHITIETPHIEUNHAP NUMBER PRIMARY KEY,
    TENSANPHAM NVARCHAR2(255),
    SOLUONG NUMBER,
    GIANHAP NUMBER(18, 2),
    THANHTIEN NUMBER(18, 2),
    ID_PHIEUNHAP NUMBER,
    ID_SANPHAM NUMBER,
    CONSTRAINT FK_CHITIETPHIEUNHAP_PHIEUNHAP FOREIGN KEY (ID_PHIEUNHAP) REFERENCES PHIEUNHAP(ID_PHIEUNHAP),
    CONSTRAINT FK_CHITIETPHIEUNHAP_SANPHAM FOREIGN KEY (ID_SANPHAM) REFERENCES SANPHAM(ID_SANPHAM)
);

DROP TABLE CHITIETPHIEUNHAP;
DROP TABLE PHIEUNHAP;
DROP TABLE CHITIETHOADON;
DROP TABLE HOADON;
DROP TABLE KHACHHANG;
DROP TABLE NHANVIEN;
DROP TABLE SANPHAM;

DELETE FROM CHITIETPHIEUNHAP;
DELETE FROM CHITIETHOADON;
DELETE FROM PHIEUNHAP;
DELETE FROM HOADON;
DELETE FROM SANPHAM;
DELETE FROM KHACHHANG;
DELETE FROM NHANVIEN;



SELECT * FROM CHITIETPHIEUNHAP;
SELECT * FROM PHIEUNHAP;
SELECT * FROM CHITIETHOADON;
SELECT * FROM HOADON;
SELECT * FROM KHACHHANG;
SELECT * FROM NHANVIEN;
SELECT * FROM SANPHAM;

GRANT SELECT ON NhanVien TO nguyentruongduy_DOAN;
SELECT * FROM nguyentruongduy_DOAN.SANPHAM;
INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) VALUES(1, 'G?o th?m', 100, 25000.00, 5.00, 'C�n h�ng');
INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) VALUES(2, '???ng tr?ng', 50, 20000.00, 10.00, 'C�n h�ng');
INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) VALUES(3, 'Mu?i tinh', 200, 10000.00, 0.00, 'C�n h�ng');
INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) VALUES(4, 'D?u ?n', 75, 45000.00, 15.00, 'C�n h�ng');
INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) VALUES(5, 'B?t m�', 80, 30000.00, 8.00, 'C�n h�ng');


INSERT INTO NHANVIEN (ID_NHANVIEN, TENNHANVIEN, CHUCVU, SDT, CCCD, NGAYSINH, DIACHI, MATKHAU, LUONG, HESOLUONG, TRANGTHAI) VALUES(1, 'Tr?n V?n Tinh', 'Qu?n l�', '0901234567', '123456789012', TO_DATE('2002-01-01', 'YYYY-MM-DD'), 'H� N?i', '123', 15000000.00, 2.0, '?ang l�m vi?c');
INSERT INTO NHANVIEN (ID_NHANVIEN, TENNHANVIEN, CHUCVU, SDT, CCCD, NGAYSINH, DIACHI, MATKHAU, LUONG, HESOLUONG, TRANGTHAI) VALUES(2, 'Nguy?n Th? H??ng', 'Nh�n vi�n b�n h�ng', '0907654321', '098765432109', TO_DATE('2003-05-05', 'YYYY-MM-DD'), 'H� N?i', '123', 10000000.00, 1.0, '?ang l�m vi?c');
INSERT INTO NHANVIEN (ID_NHANVIEN, TENNHANVIEN, CHUCVU, SDT, CCCD, NGAYSINH, DIACHI, MATKHAU, LUONG, HESOLUONG, TRANGTHAI) VALUES(3, 'L� V?n Ho�ng', 'Nh�n vi�n kho', '0912345678', '456789012345', TO_DATE('2000-03-10', 'YYYY-MM-DD'), 'H� N?i', '123', 12000000.00, 1.0, '?ang l�m vi?c');
INSERT INTO NHANVIEN (ID_NHANVIEN, TENNHANVIEN, CHUCVU, SDT, CCCD, NGAYSINH, DIACHI, MATKHAU, LUONG, HESOLUONG, TRANGTHAI) VALUES(4, 'Nguy?n Th? Mai', 'Nh�n vi�n k? to�n', '0923456789', '234567890123', TO_DATE('1998-07-15', 'YYYY-MM-DD'), '456', 'password101', 11000000.00, 1.5, '?ang l�m vi?c');
INSERT INTO NHANVIEN (ID_NHANVIEN, TENNHANVIEN, CHUCVU, SDT, CCCD, NGAYSINH, DIACHI, MATKHAU, LUONG, HESOLUONG, TRANGTHAI) VALUES(5, 'Ph?m V?n An', 'Nh�n vi�n IT', '0934567890', '345678901234', TO_DATE('2001-12-20', 'YYYY-MM-DD'), 'H� N?i', '456', 13000000.00, 1.5, '?ang l�m vi?c');

INSERT INTO KHACHHANG (ID_KHACHHANG, TENKHACHHANG, NGAYSINH, DIACHI, SDT) VALUES(1, 'Nguy?n V?n Thanh', TO_DATE('1995-06-30', 'YYYY-MM-DD'), '?� N?ng', '0945678901');
INSERT INTO KHACHHANG (ID_KHACHHANG, TENKHACHHANG, NGAYSINH, DIACHI, SDT) VALUES(2, 'Tr?n Th? Giang', TO_DATE('1980-11-25', 'YYYY-MM-DD'), 'H? Ch� Minh', '0956789012');
INSERT INTO KHACHHANG (ID_KHACHHANG, TENKHACHHANG, NGAYSINH, DIACHI, SDT) VALUES(3, 'L� V?n T�', TO_DATE('1992-04-10', 'YYYY-MM-DD'), 'H?i Ph�ng', '0967890123');
INSERT INTO KHACHHANG (ID_KHACHHANG, TENKHACHHANG, NGAYSINH, DIACHI, SDT) VALUES(4, 'Nguy?n Th? L?', TO_DATE('1987-08-15', 'YYYY-MM-DD'), 'Nha Trang', '0978901234');
INSERT INTO KHACHHANG (ID_KHACHHANG, TENKHACHHANG, NGAYSINH, DIACHI, SDT) VALUES(5, 'Ph?m V?n ??ng', TO_DATE('1990-02-20', 'YYYY-MM-DD'), 'C?n Th?', '0989012345');

INSERT INTO HOADON (ID_HOADON, NGAYLAP, TONGTIEN, GIAMGIA, ID_NHANVIEN, ID_KHACHHANG) VALUES(1, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 500000, 10, 1, 1);
INSERT INTO HOADON (ID_HOADON, NGAYLAP, TONGTIEN, GIAMGIA, ID_NHANVIEN, ID_KHACHHANG) VALUES(2, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 600000, 20, 2, 2);
INSERT INTO HOADON (ID_HOADON, NGAYLAP, TONGTIEN, GIAMGIA, ID_NHANVIEN, ID_KHACHHANG) VALUES(3, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 700000, 15, 3, 3);
INSERT INTO HOADON (ID_HOADON, NGAYLAP, TONGTIEN, GIAMGIA, ID_NHANVIEN, ID_KHACHHANG) VALUES(4, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 800000, 25, 4, 4);
INSERT INTO HOADON (ID_HOADON, NGAYLAP, TONGTIEN, GIAMGIA, ID_NHANVIEN, ID_KHACHHANG) VALUES(5, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 900000, 30, 5, 5);

INSERT INTO CHITIETHOADON (ID_CHITIETHOADON, TENSANPHAM, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN, ID_HOADON, ID_SANPHAM) VALUES(1, 'G?o th?m', 2, 25000.00, 5.00, 49500.00, 1, 1);
INSERT INTO CHITIETHOADON (ID_CHITIETHOADON, TENSANPHAM, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN, ID_HOADON, ID_SANPHAM) VALUES(2, '???ng tr?ng', 1, 20000.00, 10.00, 18000.00, 2, 2);
INSERT INTO CHITIETHOADON (ID_CHITIETHOADON, TENSANPHAM, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN, ID_HOADON, ID_SANPHAM) VALUES(3, 'Mu?i tinh', 3, 10000.00, 0.00, 30000.00, 3, 3);
INSERT INTO CHITIETHOADON (ID_CHITIETHOADON, TENSANPHAM, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN, ID_HOADON, ID_SANPHAM) VALUES(4, 'D?u ?n', 1, 45000.00, 15.00, 38250.00, 4, 4);
INSERT INTO CHITIETHOADON (ID_CHITIETHOADON, TENSANPHAM, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN, ID_HOADON, ID_SANPHAM) VALUES(5, 'B?t m�', 5, 30000.00, 8.00, 146000.00, 5, 5);

INSERT INTO PHIEUNHAP (ID_PHIEUNHAP, NGAYLAPPHIEU, NHACUNGCAP, TONGTIEN, ID_NHANVIEN) VALUES(1, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 'Nh� cung c?p 1', 1000000.00, 1);
INSERT INTO PHIEUNHAP (ID_PHIEUNHAP, NGAYLAPPHIEU, NHACUNGCAP, TONGTIEN, ID_NHANVIEN) VALUES(2, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 'Nh� cung c?p 2', 1500000.00, 2);
INSERT INTO PHIEUNHAP (ID_PHIEUNHAP, NGAYLAPPHIEU, NHACUNGCAP, TONGTIEN, ID_NHANVIEN) VALUES(3, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 'Nh� cung c?p 3', 2000000.00, 3);
INSERT INTO PHIEUNHAP (ID_PHIEUNHAP, NGAYLAPPHIEU, NHACUNGCAP, TONGTIEN, ID_NHANVIEN) VALUES(4, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 'Nh� cung c?p 4', 2500000.00, 4);
INSERT INTO PHIEUNHAP (ID_PHIEUNHAP, NGAYLAPPHIEU, NHACUNGCAP, TONGTIEN, ID_NHANVIEN) VALUES(5, TO_DATE('2021-01-01', 'YYYY-MM-DD'), 'Nh� cung c?p 5', 3000000.00, 5);

INSERT INTO CHITIETPHIEUNHAP (ID_CHITIETPHIEUNHAP, TENSANPHAM, SOLUONG, GIANHAP, THANHTIEN, ID_PHIEUNHAP, ID_SANPHAM) VALUES (1, 'G?o th?m', 10, 24000.00, 240000.00, 1, 1);
INSERT INTO CHITIETPHIEUNHAP (ID_CHITIETPHIEUNHAP, TENSANPHAM, SOLUONG, GIANHAP, THANHTIEN, ID_PHIEUNHAP, ID_SANPHAM) VALUES (2, '???ng tr?ng', 20, 19000.00, 380000.00, 2, 2);
INSERT INTO CHITIETPHIEUNHAP (ID_CHITIETPHIEUNHAP, TENSANPHAM, SOLUONG, GIANHAP, THANHTIEN, ID_PHIEUNHAP, ID_SANPHAM) VALUES (3, 'Mu?i tinh', 15, 9500.00, 142500.00, 3, 3);
INSERT INTO CHITIETPHIEUNHAP (ID_CHITIETPHIEUNHAP, TENSANPHAM, SOLUONG, GIANHAP, THANHTIEN, ID_PHIEUNHAP, ID_SANPHAM) VALUES (4, 'D?u ?n', 5, 42000.00, 210000.00, 4, 4);
INSERT INTO CHITIETPHIEUNHAP (ID_CHITIETPHIEUNHAP, TENSANPHAM, SOLUONG, GIANHAP, THANHTIEN, ID_PHIEUNHAP, ID_SANPHAM) VALUES (5, 'B?t m�', 25, 29000.00, 725000.00, 5, 5);

CREATE TABLE ENCRYPTION_KEYS (
    KEY_RAW RAW(32),
    IV_RAW RAW(16)
);

-- T?o m?t c?p kh�a
BEGIN
    INSERT INTO ENCRYPTION_KEYS 
    VALUES (
        UTL_RAW.CAST_TO_RAW('0123456789ABCDEF0123456789ABCDEF'),
        UTL_RAW.CAST_TO_RAW('1234567890ABCDEF')
    );
    COMMIT;
END;
/
grant create procedure to nguyentruongduy_DOAN
GRANT EXECUTE ON DBMS_CRYPTO TO nguyentruongduy_DOAN;
GRANT CREATE SEQUENCE TO nguyentruongduy_DOAN;
GRANT EXECUTE ON GetMaxIdSanPham TO nguyentruongduy_DOAN;
GRANT EXECUTE ON THEM_SANPHAM TO nguyentruongduy_DOAN;
GRANT EXECUTE ON GET_SANPHAM_LIST TO nguyentruongduy_DOAN;

CREATE OR REPLACE PROCEDURE THEM_SANPHAM(
    p_tenSanPham IN VARCHAR2,
    p_soLuong IN INT,
    p_gia IN DECIMAL,
    p_khuyenMai IN DECIMAL,
    p_trangThai IN VARCHAR2
) IS
BEGIN
    INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI)
    VALUES (SANPHAM_SEQ.NEXTVAL, p_tenSanPham, p_soLuong, p_gia, p_khuyenMai, p_trangThai);
END;


CREATE OR REPLACE PROCEDURE GetMaxIdSanPham
  (RETURN_VALUE OUT INT) AS
BEGIN
  SELECT MAX(ID_SANPHAM) INTO RETURN_VALUE FROM SANPHAM;
END GetMaxIdSanPham;

DESCRIBE GETMAXIDSANPHAM;


CREATE OR REPLACE PROCEDURE GET_SANPHAM_LIST (
    p_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN p_cursor FOR
    SELECT ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI
    FROM SANPHAM;
END GET_SANPHAM_LIST;




/


CREATE SEQUENCE SANPHAM_SEQ
START WITH 1
INCREMENT BY 1
NOCACHE
NOCYCLE;









-- H�m m� h�a s?a ??i
CREATE OR REPLACE FUNCTION encrypt_data(input_text IN VARCHAR2) RETURN RAW AS
    encrypted_text RAW(2000);
    key_raw RAW(32);
    iv_raw RAW(16);
BEGIN
    -- L?y gi� tr? KEY_RAW v� IV_RAW t? b?ng ENCRYPTION_KEYS
    SELECT KEY_RAW, IV_RAW INTO key_raw, iv_raw FROM ENCRYPTION_KEYS;

    -- M� h�a d? li?u
    encrypted_text := DBMS_CRYPTO.ENCRYPT(
        src => UTL_RAW.CAST_TO_RAW(input_text),  -- D? li?u ph?i l� RAW
        typ => DBMS_CRYPTO.ENCRYPT_AES256 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5,
        key => key_raw,
        iv  => iv_raw
    );
    RETURN encrypted_text;
END encrypt_data;
/
/

-- H�m gi?i m� s?a ??i

CREATE OR REPLACE FUNCTION decrypt_data(encrypted_text IN RAW) RETURN VARCHAR2 AS
    decrypted_text VARCHAR2(2000);
    key_raw RAW(32);
    iv_raw RAW(16);
BEGIN
    -- L?y gi� tr? KEY_RAW v� IV_RAW t? b?ng ENCRYPTION_KEYS
    SELECT KEY_RAW, IV_RAW INTO key_raw, iv_raw FROM ENCRYPTION_KEYS;

    -- Gi?i m� d? li?u
    decrypted_text := UTL_RAW.CAST_TO_VARCHAR2(
        DBMS_CRYPTO.DECRYPT(
            src => encrypted_text,
            typ => DBMS_CRYPTO.ENCRYPT_AES256 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5,
            key => key_raw,
            iv  => iv_raw
        )
    );
    RETURN decrypted_text;
END decrypt_data;
/

SELECT 
    DBMS_CRYPTO.DECRYPT(TENSANPHAM, 'your_key') AS TENSANPHAM,
    SOLUONG, 
    GIA, 
    KHUYENMAI,
    DBMS_CRYPTO.DECRYPT(TRANGTHAI, 'your_key') AS TRANGTHAI
FROM SANPHAM;




