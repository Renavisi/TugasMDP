package com.example.rena.aplikasimodul2kel33.ui.detailCar;

import com.example.rena.aplikasimodul2kel33.data.model.DataCar;

import java.util.List;

public interface DetailView {
    void showErrorCarById(String message);

    void showSuccessCarById(List<DataCar> dataCar);
}
