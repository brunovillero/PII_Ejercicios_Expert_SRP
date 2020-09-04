using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        //Considero que la clase cumple con expert, contiene toda la informacion relacionado para poder crear un appointment

        //Pero no cumple con SRP, contiene una cantidad de parametros que estan relacionados a objetos que podemos crear
        //Para asi distribuir las responsabilidades entre el programa
        //En este caso un appointment se crea a parti de datos de un cliente, una clinica y un doctor,
        //Podemos crear esas clases para distribuir entre ellas las responsabilidades de validacion de informacion

        public static string CreateAppointment(Client client, Clinic clinic, Doctor doctor, DateTime date)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (client.Name == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (client.Id == null)
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (client.PhoneNumber == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (clinic.Address == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (doctor.Name == null)
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
