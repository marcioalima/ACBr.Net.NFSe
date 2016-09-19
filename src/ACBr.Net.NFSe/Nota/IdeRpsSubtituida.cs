// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 06-07-2016
//
// Last Modified By : RFTD
// Last Modified On : 06-07-2016
// ***********************************************************************
// <copyright file="IdeRpsSubtituida.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.Core.Generics;
using System;
using PropertyChanged;

#region COM Interop Attributes

#if COM_INTEROP

using System.Runtime.InteropServices;

#endif

#endregion COM Interop Attributes

namespace ACBr.Net.NFSe.Nota
{
	#region COM Interop Attributes

#if COM_INTEROP

	[ComVisible(true)]
	[Guid("8B3065B7-2899-4B37-9737-148290A4582E")]
	[ClassInterface(ClassInterfaceType.None)]
#endif

	#endregion COM Interop Attributes

	[ImplementPropertyChanged]
	public sealed class IdeRpsSubtituida : GenericClone<IdeRpsSubtituida>
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="IdeRps"/> class.
		/// </summary>
		internal IdeRpsSubtituida()
		{
			NumeroRps = string.Empty;
			NumeroNfse = string.Empty;
			Serie = string.Empty;
		}

		#endregion Constructor

		#region Propriedades

		/// <summary>
		/// Gets or sets the numero.
		/// </summary>
		/// <value>The numero.</value>
		public string NumeroRps { get; set; }

		/// <summary>
		/// Gets or sets the numero.
		/// </summary>
		/// <value>The numero.</value>
		public string NumeroNfse { get; set; }

		/// <summary>
		/// Gets or sets the serie.
		/// </summary>
		/// <value>The serie.</value>
		public string Serie { get; set; }

		/// <summary>
		/// Gets or sets the tipo.
		/// </summary>
		/// <value>The tipo.</value>
		public TipoRps Tipo { get; set; }

		/// <summary>
		/// Gets or sets the data emissao nf se substituida.
		/// </summary>
		/// <value>The data emissao nf se substituida.</value>
		public DateTime DataEmissaoNfseSubstituida { get; set; }

		public string NFSeSubstituidora { get; set; }

		#endregion Propriedades
	}
}