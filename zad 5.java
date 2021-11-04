package com.example.zad1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private Button buttona;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        addClickOnButton();
    }

    public static int fi(int funcValue){
        if(funcValue==0){
            return 0;
        }
        else if(funcValue==1){
            return 1;
        }
        else{
            return fi(funcValue-1)+fi(funcValue-2);
        }
    }


    int counter = 0;
    private void addClickOnButton() {

        buttona = (Button) findViewById(R.id.button);
        buttona.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Toast.makeText(getApplicationContext(),String.valueOf(fi(counter)), Toast.LENGTH_SHORT).show();
                counter++;
            }

        });

    }
}