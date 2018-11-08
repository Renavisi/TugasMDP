package com.example.rena.aplikasimodul2kel33.ui.home;

        import com.example.rena.aplikasimodul2kel33.data.model.DataCar;

        import java.util.List;

public interface HomeView {
    void successShowCar(List<DataCar> dataCars);
    void failedShowCar(String message);

}
