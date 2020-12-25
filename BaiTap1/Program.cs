using System;

namespace BaiTap1
{
	class CongNhan
	{
		private string soCMND;
		private string hoTen;
		private int gioiTinh;
		private DateTime ngaySinh;
		private string diaChi;

		public string SoCMND
		{
			get { return soCMND; }
			set { soCMND = value; }
		}

		public CongNhan()
		{
			Console.Write("Nhap SoCMND =  ");
			soCMND = Console.ReadLine();

			Console.Write("Nhap  Ho Ten = ");
			hoTen = Console.ReadLine();

			do
			{
				Console.Write("Nhap Gioi Tinh(1.Nu | 2.Nam) = ");
				gioiTinh = Convert.ToInt32(Console.ReadLine());

				if (gioiTinh != 1 && gioiTinh != 2)
				{
					Console.WriteLine("Khong ton tai gioi tinh nay ?");
				}
			}
			while (gioiTinh != 1 && gioiTinh != 2);

			Console.Write("Nhap ngay sinh = ");
			ngaySinh = Convert.ToDateTime(Console.ReadLine());

			Console.Write("Nhap Dia chi =  ");
			diaChi = Console.ReadLine();
		}

	public virtual void Xuat()
	{
		string gioiTinhCongNhan = "";

		if (gioiTinh == 1)  gioiTinhCongNhan = "Nu";
		else if (gioiTinh == 2) gioiTinhCongNhan = "Nam";

		Console.Write("(SoCMND = {0}, HoTen = {1}, GioiTinh = {2}, NgaySinh = {3}, DiaChi = {4})",  soCMND, hoTen, gioiTinhCongNhan, ngaySinh.ToString("dd/mm/yyyy"), diaChi);
	}

}

class CongNhanSX : CongNhan
{
	private string maCongNhan;
	private string maDonVi;
	private int chucVu;

	public CongNhanSX() : base()
	{
		Console.Write("Nhap Ma Cong Nhan =  ");
		maCongNhan = Console.ReadLine();

		Console.Write("Nhap Ma Don Vi = ");
		maDonVi = Console.ReadLine();

		do
		{
			Console.Write("Nhap Chuc Vu(1.Khong To Truong | 2.To Truong) =  ");
			chucVu = Convert.ToInt32(Console.ReadLine());

			if (chucVu != 1 && chucVu != 2)
			{
				Console.WriteLine("Khong ton tai chuc vu  nay ?");
			}
		}
		while (chucVu != 1 && chucVu != 2);
	}

	public override void Xuat()
	{
		base.Xuat();
		String chucVuCongNhan = "";

		if(chucVu == 1)  chucVuCongNhan = "Khong To Truong";
		else if (chucVu == 2) chucVuCongNhan = "To Truong";

		Console.Write("(MaCongNhan = { 0}, MaDonVi = { 1}, ChucVu = { 2})", maCongNhan, maDonVi, chucVuCongNhan );
	
	}

	public static bool operator ==(CongNhanSX cn1, CongNhanSX cn2)
	{
		return cn1.maCongNhan == cn2.maCongNhan;
	}

	public static bool operator !=(CongNhanSX cn1, CongNhanSX cn2)
	{
		return cn1.maCongNhan != cn2.maCongNhan;
	}

}

	class Program
	{
		private static CongNhanSX[] ChuyenSX;
		private static int n;

		static void Main()
		{
			do
			{
				try
				{
					Console.Write("Nhap n =  ");
					n = Convert.ToInt32(Console.ReadLine());
				}
				catch(FormatException e)
				{
						Console.WriteLine("Nhap khong dung kieu du lieu! Nhap lai!");
						continue;
				}

				if(n < 0)
				{
					Console.WriteLine("Nhap ko hop le! N PHAI la so Duong");
				}
			} while (n < 0) ;

			ChuyenSX = new CongNhanSX[n];

			NhapDanhSach();

			XuatDanhSach();

			Console.ReadLine();
		}

		static void NhapDanhSach()
		{
			for(int i = 0; i < n; i++)
			{
				ChuyenSX[i] = new CongNhanSX();
			}
		}

		static void XuatDanhSach()
		{
			for (int i = 0; i < n; i++)
			{
				ChuyenSX[i].Xuat();
			}
		}

		static bool KiemTraTonTaiCongNhan(CongNhanSX congNhanKiemTra)
        {
            for (int i = 0; i < n; i++)
            {
                if (congNhanKiemTra == ChuyenSX[i])
                {				
					return true;
				}
            }

			return false;
        }
	} 
}
