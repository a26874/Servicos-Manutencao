package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityLoginBinding

class LoginActivity : AppCompatActivity() {

    private val binding by lazy {
        ActivityLoginBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeLogin()
    }

    private fun initializeLogin(){
        binding.entrarbtn.setOnClickListener{
            startActivity(
                Intent(this, MainMenuActivity::class.java )
            )
        }
    }
}