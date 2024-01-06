package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import pt.ipca.userprogram.databinding.ActivityMainMenuBinding

class MainMenuActivity : AppCompatActivity() {
    private val binding by lazy {
        ActivityMainMenuBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeMenu()
    }

    private fun initializeMenu(){
        binding.jardinagembtn.setOnClickListener{
            Toast.makeText(this, "Serviço escolhido com sucesso!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, JardinagemMainMenu::class.java )
            )
        }

        binding.pinturabtn.setOnClickListener{
            Toast.makeText(this, "Serviço escolhido com sucesso!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, PinturaMainMenu::class.java )
            )
        }

        binding.limpezabtn.setOnClickListener{
            Toast.makeText(this, "Serviço escolhido com sucesso!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, LimpezaMainMenu::class.java )
            )
        }
    }
}