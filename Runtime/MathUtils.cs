using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bisscuit.MathUtils
{
    public static class MathUtils
    {
        public static string CashConverter(float cash)
        {
            string textConverter = string.Empty;
            float cashConverter = cash;

            if (cash < 1000)
            {
                textConverter = cashConverter.ToString();
                return textConverter;
            }

            if (cash >= 1000)
            {
                float checkDecimalValue = cashConverter / 1000.0f;
                if (checkDecimalValue % 2 == 0 || checkDecimalValue % 2 == 1)
                {
                    textConverter = Math.Floor(cashConverter / 1000).ToString() + "K"; //thousand
                }
                else
                {

                    int valueThousand = (int)Math.Floor(checkDecimalValue);
                    textConverter = valueThousand.ToString() + "K";
                }
            }

            if (cash >= 1000000)
            {
                float checkDecimalValue = cashConverter / 1000000.0f;
                if (checkDecimalValue % 2 == 0 || checkDecimalValue % 2 == 1)
                {
                    textConverter = Math.Floor(cashConverter / 1000000).ToString() + "M"; //million
                }
                else
                {
                    int valueMillion = (int)Math.Floor(checkDecimalValue);
                    int valueThousand = (int)Math.Floor((checkDecimalValue - valueMillion) * 1000);

                    textConverter = valueMillion.ToString() + "M" + valueThousand.ToString() + "K";// (cashConverter / 1000000.0f).ToString("F1") + "M"; //million
                }
            }
            return textConverter;
        }
    }
}
