package pt.ipca.userprogram

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import pt.ipca.userprogram.databinding.ActivityFormaPagamentoBinding

class FormaPagamento : AppCompatActivity() {

    private val binding by lazy {
        ActivityFormaPagamentoBinding.inflate(layoutInflater)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        initializeFormaPagamento()
    }

    private fun initializeFormaPagamento(){
        binding.mbwaybtn.setOnClickListener{
            Toast.makeText(this, "Pagamento realizado por mbway!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, FinalActivity::class.java )
            )
        }


        binding.transferenciabtn.setOnClickListener{
            Toast.makeText(this, "Pagamento realizado por transferência bancária!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, FinalActivity::class.java )
            )
        }


        binding.multibancobtn.setOnClickListener{
            Toast.makeText(this, "Pagamento realizado por multibanco!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, FinalActivity::class.java )
            )
        }


        binding.paypalbtn.setOnClickListener{
            Toast.makeText(this, "Pagamento realizado por paypal!", Toast.LENGTH_SHORT).show()
            startActivity(
                Intent(this, FinalActivity::class.java )
            )
        }
    }
}