package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityPinturaMainMenuBinding

class PinturaMainMenu : AppCompatActivity() {

    private val binding by lazy {
        ActivityPinturaMainMenuBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializePintura()
    }

    private fun initializePintura(){
        binding.pintura1btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
        binding.pintura2btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
    }
}