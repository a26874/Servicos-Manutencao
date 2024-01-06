package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private val binding by lazy {
        ActivityMainBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)
        initializeViews()
    }

    private fun initializeViews(){
        binding.loginbtn.setOnClickListener{
            startActivity(
                Intent(this, LoginActivity::class.java )
            )
        }
    }
}