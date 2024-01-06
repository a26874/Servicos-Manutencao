package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityFinalBinding

class FinalActivity : AppCompatActivity() {

    private val binding by lazy {
        ActivityFinalBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeFinal()
    }

    private fun initializeFinal(){
        binding.iniciobtn.setOnClickListener{
            startActivity(
                Intent(this, MainMenuActivity::class.java )
            )
        }
    }
}