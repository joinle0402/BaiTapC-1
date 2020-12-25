using System;

namespace BaiTap1
{
	Class CongNhan
	{
		private string soCMND;
		private string hoTen;
		private int gioiTinh;
		private DateTime ngaySinh;
		private string diaChi;

		public string SoCMND
		{
			get { return soCMND; }
			set { }
		}


		public CongNhan()
		{
			Console.Write(“Nhap SoCMND =  ”);
			soCMND = Console.WriteLine();

			Console.Write(“Nhap  Ho Ten = ”);
			hoTen = Console.WriteLine();

			do
			{
				Console.Write(“Nhap Gioi Tinh(1.Nu | 2.Nam) = ”);
				gioiTinh = Convert.ToInt32(Console.WriteLine());

				if (gioiTinh != 1 && gioiTinh != 2)
				{
					Console.WriteLine(“Khong ton tai gioi tinh nay ?”);
				}
			}
			while (gioiTinh != 1 && gioiTinh != 2);

			Console.Write(“Nhap ngay sinh = ”);
			ngaySinh = Convert.ToDateTime(Console.WriteLine());

			Console.Write(“Nhap Dia chi =  ”);
			diaChi = Console.WriteLine();
		}

	public virtual void Xuat()
	{
		String gioiTinhCongNhan = “”;

		If(gioiTinh == 1)  gioiTinhCongNhan = “Nu”;
		Else if (gioiTinh == 2) gioiTinhCongNhan = “Nam”;

		Console.Write("(SoCMND = { 0}, HoTen = { 1}, GioiTinh = { 2}, NgaySinh = {3}, DiaChi = {4})",  soCMND, hoTen, gioiTinhCongNhan, ngaySinh.ToString(“dd / mm / yyyy”), diaChi);
	}

}

Class CongNhanSX : CongNhan
{
	Private string maCongNhan;
	Private string maDonVi;
	Private int chucVu;

	public CongNhanSX() : base()
	{
		Console.Write(“Nhap Ma Cong Nhan =  ”);
		maCongNhan = Console.WriteLine();

		Console.Write(“Nhap Ma Don Vi =  ”);
		maDonVi = Console.WriteLine();

		do
		{
			Console.Write(“Nhap Chuc Vu(1.Khong To Truong | 2.To Truong) =  ”);
			chucVu = Convert.ToInt32(Console.WriteLine());

			if (chucVu != 1 && chucVu != 2)
			{
				Console.WriteLine(“Khong ton tai chuc vu  nay ?”);
			}
		}
		while (chucVu != 1 && chucVu != 2);
	}

	public override void Xuat()
	{
		Base.Xuat();
		String chucVuCongNhan = “”;

		If(chucVu == 1)  chucVuCongNhan = “Khong To Truong”;
		Else if (chucVu == 2) chucVuCongNhan = “To Truong”;

		Console.Write( “(MaCongNhan = { 0}, MaDonVi = { 1}, ChucVu = { 2})”, maCongNhan, maDonVi, chucVuCongNhan );
}

public static bool operator ==(CongNhanSX cn1, CongNhanSX cn2)
{
	Return cn1.maCongNhan == cn2.maCongNhan;
}

// true false
public static bool operator !=(CongNhanSX cn1, CongNhanSX cn2)
{
	Return cn1.maCongNhan != cn2.maCongNhan;
}

}

	class Program
{
	Private CongNhanSX[] ChuyenSX;
		Private int n;

	Static void Main()
	{
		Do
{
			Try
	{
				Console.Write(“Nhap n =  ”);
				n = Convert.ToInt32(Console.WriteLine());
			}
			Catch(FormatException e)
{
				Console.WriteLine(“Nhap khong dung kieu du lieu! Nhap lai!”)
	Continue;
			}

			If(n < 0)
{
				Console.WriteLine(“Nhap ko hop le! N PHAI la so Duong”);
			}
		} while (n < 0) ;

		ChuyenSX = new CongNhanSX[n];

		NhapDanhSach();

		XuatDanhSach();

		Console.ReadLine();
	}

	Static void NhapDanhSach()
	{
		For(int i = 0; I < n; i++)
{
			ChuyenSX[i] = new CongNhanSX();
		}
	}

	Static void XuatDanhSach()
	{
		For(int i = 0; I < n; i++)
		{
			ChuyenSX[i].Xuat();
		}
	}
} 
}
