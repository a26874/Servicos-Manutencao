package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityLimpezaMainMenuBinding

class LimpezaMainMenu : AppCompatActivity() {

    private val binding by lazy {
        ActivityLimpezaMainMenuBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeLimpeza()
    }

    private fun initializeLimpeza(){
        binding.limpeza1btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
        binding.limpeza2btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
    }
}