﻿namespace QuanLyDaiLy.Entities;

public class ThamSo
{
    public string Id { get; set; } = "";
    public decimal SoTienGoiToiThieu { get; set; } = 100000;
    public bool ApDungSoTienGuiToiThieu { get; set; } = true;
    public decimal SoTienGuiThemToiThieu { get; set; } = 100000;
    public int SoNgayMoToiThieu { get; set; } = 15;
    public int SoNgayMoToiThieuDeCoLai { get; set; } = 30;

}