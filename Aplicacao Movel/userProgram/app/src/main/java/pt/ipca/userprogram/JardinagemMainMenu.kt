package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import pt.ipca.userprogram.databinding.ActivityJardinagemMainMenuBinding

class JardinagemMainMenu : AppCompatActivity() {

    private val binding by lazy {
        ActivityJardinagemMainMenuBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeJardinagem()
    }

    private fun initializeJardinagem(){
        binding.jardinagem1btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
        binding.jardinagem2btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
        binding.jardinagem3btn.setOnClickListener{
            startActivity(
                Intent(this, FormaPagamento::class.java )
            )
        }
    }
}