
namespace COBRANZA
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.tabmenuprincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabSelectorClientes = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcClientes = new MaterialSkin.Controls.MaterialTabControl();
            this.tabClientesRegistro = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabClientesConsulta = new System.Windows.Forms.TabPage();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.tabSelectorServicios = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcServicios = new MaterialSkin.Controls.MaterialTabControl();
            this.tabServiciosRegistro = new System.Windows.Forms.TabPage();
            this.tabServicioConsulta = new System.Windows.Forms.TabPage();
            this.tabServiciosPrecio = new System.Windows.Forms.TabPage();
            this.tabMorosidad = new System.Windows.Forms.TabPage();
            this.tabSelectorMorocidad = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcMorosidad = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMorosidadListaMora = new System.Windows.Forms.TabPage();
            this.tabMorosidadPlandePago = new System.Windows.Forms.TabPage();
            this.tabMorosidadNotificaciones = new System.Windows.Forms.TabPage();
            this.tabConfiguraciones = new System.Windows.Forms.TabPage();
            this.tabSelectorConfigraciones = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabOpcConfiguraciones = new MaterialSkin.Controls.MaterialTabControl();
            this.tabConfiguracionesUsuarios = new System.Windows.Forms.TabPage();
            this.tabConfiguracionesAccesos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionesModulos = new System.Windows.Forms.TabPage();
            this.tabConfiguracionesParametros = new System.Windows.Forms.TabPage();
            this.imglistmenuprincipal = new System.Windows.Forms.ImageList(this.components);
            this.mnustripmenuprincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morosidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabmenuprincipal.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabOpcClientes.SuspendLayout();
            this.tabClientesRegistro.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.tabOpcServicios.SuspendLayout();
            this.tabMorosidad.SuspendLayout();
            this.tabOpcMorosidad.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.tabOpcConfiguraciones.SuspendLayout();
            this.mnustripmenuprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabmenuprincipal
            // 
            this.tabmenuprincipal.Controls.Add(this.tabClientes);
            this.tabmenuprincipal.Controls.Add(this.tabServicios);
            this.tabmenuprincipal.Controls.Add(this.tabMorosidad);
            this.tabmenuprincipal.Controls.Add(this.tabConfiguraciones);
            this.tabmenuprincipal.Depth = 0;
            this.tabmenuprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabmenuprincipal.ImageList = this.imglistmenuprincipal;
            this.tabmenuprincipal.Location = new System.Drawing.Point(3, 88);
            this.tabmenuprincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabmenuprincipal.Multiline = true;
            this.tabmenuprincipal.Name = "tabmenuprincipal";
            this.tabmenuprincipal.SelectedIndex = 0;
            this.tabmenuprincipal.Size = new System.Drawing.Size(951, 499);
            this.tabmenuprincipal.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabSelectorClientes);
            this.tabClientes.Controls.Add(this.tabOpcClientes);
            this.tabClientes.ImageIndex = 4;
            this.tabClientes.Location = new System.Drawing.Point(4, 23);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(943, 472);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabSelectorClientes
            // 
            this.tabSelectorClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorClientes.BaseTabControl = this.tabOpcClientes;
            this.tabSelectorClientes.Depth = 0;
            this.tabSelectorClientes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorClientes.Location = new System.Drawing.Point(-4, 0);
            this.tabSelectorClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorClientes.Name = "tabSelectorClientes";
            this.tabSelectorClientes.Size = new System.Drawing.Size(951, 48);
            this.tabSelectorClientes.TabIndex = 1;
            this.tabSelectorClientes.Text = "materialTabSelector1";
            // 
            // tabOpcClientes
            // 
            this.tabOpcClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcClientes.Controls.Add(this.tabClientesRegistro);
            this.tabOpcClientes.Controls.Add(this.tabClientesConsulta);
            this.tabOpcClientes.Depth = 0;
            this.tabOpcClientes.Location = new System.Drawing.Point(0, 54);
            this.tabOpcClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcClientes.Multiline = true;
            this.tabOpcClientes.Name = "tabOpcClientes";
            this.tabOpcClientes.SelectedIndex = 0;
            this.tabOpcClientes.Size = new System.Drawing.Size(937, 417);
            this.tabOpcClientes.TabIndex = 0;
            // 
            // tabClientesRegistro
            // 
            this.tabClientesRegistro.Controls.Add(this.materialCard1);
            this.tabClientesRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabClientesRegistro.Name = "tabClientesRegistro";
            this.tabClientesRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientesRegistro.Size = new System.Drawing.Size(929, 391);
            this.tabClientesRegistro.TabIndex = 0;
            this.tabClientesRegistro.Text = "Registro";
            this.tabClientesRegistro.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(895, 347);
            this.materialCard1.TabIndex = 0;
            // 
            // tabClientesConsulta
            // 
            this.tabClientesConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabClientesConsulta.Name = "tabClientesConsulta";
            this.tabClientesConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientesConsulta.Size = new System.Drawing.Size(929, 391);
            this.tabClientesConsulta.TabIndex = 1;
            this.tabClientesConsulta.Text = "Consulta";
            this.tabClientesConsulta.UseVisualStyleBackColor = true;
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.tabSelectorServicios);
            this.tabServicios.Controls.Add(this.tabOpcServicios);
            this.tabServicios.ImageIndex = 3;
            this.tabServicios.Location = new System.Drawing.Point(4, 23);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(943, 472);
            this.tabServicios.TabIndex = 1;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // tabSelectorServicios
            // 
            this.tabSelectorServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorServicios.BaseTabControl = this.tabOpcServicios;
            this.tabSelectorServicios.Depth = 0;
            this.tabSelectorServicios.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorServicios.Location = new System.Drawing.Point(-4, 0);
            this.tabSelectorServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorServicios.Name = "tabSelectorServicios";
            this.tabSelectorServicios.Size = new System.Drawing.Size(846, 48);
            this.tabSelectorServicios.TabIndex = 3;
            this.tabSelectorServicios.Text = "materialTabSelector1";
            // 
            // tabOpcServicios
            // 
            this.tabOpcServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcServicios.Controls.Add(this.tabServiciosRegistro);
            this.tabOpcServicios.Controls.Add(this.tabServicioConsulta);
            this.tabOpcServicios.Controls.Add(this.tabServiciosPrecio);
            this.tabOpcServicios.Depth = 0;
            this.tabOpcServicios.Location = new System.Drawing.Point(0, 54);
            this.tabOpcServicios.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcServicios.Multiline = true;
            this.tabOpcServicios.Name = "tabOpcServicios";
            this.tabOpcServicios.SelectedIndex = 0;
            this.tabOpcServicios.Size = new System.Drawing.Size(832, 290);
            this.tabOpcServicios.TabIndex = 2;
            // 
            // tabServiciosRegistro
            // 
            this.tabServiciosRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabServiciosRegistro.Name = "tabServiciosRegistro";
            this.tabServiciosRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiciosRegistro.Size = new System.Drawing.Size(824, 264);
            this.tabServiciosRegistro.TabIndex = 0;
            this.tabServiciosRegistro.Text = "Registro";
            this.tabServiciosRegistro.UseVisualStyleBackColor = true;
            // 
            // tabServicioConsulta
            // 
            this.tabServicioConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabServicioConsulta.Name = "tabServicioConsulta";
            this.tabServicioConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicioConsulta.Size = new System.Drawing.Size(824, 264);
            this.tabServicioConsulta.TabIndex = 1;
            this.tabServicioConsulta.Text = "Consulta";
            this.tabServicioConsulta.UseVisualStyleBackColor = true;
            // 
            // tabServiciosPrecio
            // 
            this.tabServiciosPrecio.Location = new System.Drawing.Point(4, 22);
            this.tabServiciosPrecio.Name = "tabServiciosPrecio";
            this.tabServiciosPrecio.Size = new System.Drawing.Size(824, 264);
            this.tabServiciosPrecio.TabIndex = 2;
            this.tabServiciosPrecio.Text = "Precio";
            this.tabServiciosPrecio.UseVisualStyleBackColor = true;
            // 
            // tabMorosidad
            // 
            this.tabMorosidad.Controls.Add(this.tabSelectorMorocidad);
            this.tabMorosidad.Controls.Add(this.tabOpcMorosidad);
            this.tabMorosidad.ImageIndex = 2;
            this.tabMorosidad.Location = new System.Drawing.Point(4, 23);
            this.tabMorosidad.Name = "tabMorosidad";
            this.tabMorosidad.Size = new System.Drawing.Size(943, 472);
            this.tabMorosidad.TabIndex = 2;
            this.tabMorosidad.Text = "Morosidad";
            this.tabMorosidad.UseVisualStyleBackColor = true;
            // 
            // tabSelectorMorocidad
            // 
            this.tabSelectorMorocidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorMorocidad.BaseTabControl = this.tabOpcMorosidad;
            this.tabSelectorMorocidad.Depth = 0;
            this.tabSelectorMorocidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorMorocidad.Location = new System.Drawing.Point(-4, 0);
            this.tabSelectorMorocidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMorocidad.Name = "tabSelectorMorocidad";
            this.tabSelectorMorocidad.Size = new System.Drawing.Size(846, 48);
            this.tabSelectorMorocidad.TabIndex = 5;
            this.tabSelectorMorocidad.Text = "materialTabSelector1";
            // 
            // tabOpcMorosidad
            // 
            this.tabOpcMorosidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcMorosidad.Controls.Add(this.tabMorosidadListaMora);
            this.tabOpcMorosidad.Controls.Add(this.tabMorosidadPlandePago);
            this.tabOpcMorosidad.Controls.Add(this.tabMorosidadNotificaciones);
            this.tabOpcMorosidad.Depth = 0;
            this.tabOpcMorosidad.Location = new System.Drawing.Point(0, 54);
            this.tabOpcMorosidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcMorosidad.Multiline = true;
            this.tabOpcMorosidad.Name = "tabOpcMorosidad";
            this.tabOpcMorosidad.SelectedIndex = 0;
            this.tabOpcMorosidad.Size = new System.Drawing.Size(832, 290);
            this.tabOpcMorosidad.TabIndex = 4;
            // 
            // tabMorosidadListaMora
            // 
            this.tabMorosidadListaMora.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadListaMora.Name = "tabMorosidadListaMora";
            this.tabMorosidadListaMora.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorosidadListaMora.Size = new System.Drawing.Size(824, 264);
            this.tabMorosidadListaMora.TabIndex = 0;
            this.tabMorosidadListaMora.Text = "Lista Mora";
            this.tabMorosidadListaMora.UseVisualStyleBackColor = true;
            // 
            // tabMorosidadPlandePago
            // 
            this.tabMorosidadPlandePago.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadPlandePago.Name = "tabMorosidadPlandePago";
            this.tabMorosidadPlandePago.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorosidadPlandePago.Size = new System.Drawing.Size(824, 264);
            this.tabMorosidadPlandePago.TabIndex = 1;
            this.tabMorosidadPlandePago.Text = "Plan de Pago";
            this.tabMorosidadPlandePago.UseVisualStyleBackColor = true;
            // 
            // tabMorosidadNotificaciones
            // 
            this.tabMorosidadNotificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabMorosidadNotificaciones.Name = "tabMorosidadNotificaciones";
            this.tabMorosidadNotificaciones.Size = new System.Drawing.Size(824, 264);
            this.tabMorosidadNotificaciones.TabIndex = 2;
            this.tabMorosidadNotificaciones.Text = "Precio";
            this.tabMorosidadNotificaciones.UseVisualStyleBackColor = true;
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.tabSelectorConfigraciones);
            this.tabConfiguraciones.Controls.Add(this.tabOpcConfiguraciones);
            this.tabConfiguraciones.ImageIndex = 0;
            this.tabConfiguraciones.Location = new System.Drawing.Point(4, 23);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.Size = new System.Drawing.Size(943, 472);
            this.tabConfiguraciones.TabIndex = 3;
            this.tabConfiguraciones.Text = "Configuraciones";
            this.tabConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // tabSelectorConfigraciones
            // 
            this.tabSelectorConfigraciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorConfigraciones.BaseTabControl = this.tabOpcConfiguraciones;
            this.tabSelectorConfigraciones.Depth = 0;
            this.tabSelectorConfigraciones.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorConfigraciones.Location = new System.Drawing.Point(-4, 0);
            this.tabSelectorConfigraciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorConfigraciones.Name = "tabSelectorConfigraciones";
            this.tabSelectorConfigraciones.Size = new System.Drawing.Size(794, 48);
            this.tabSelectorConfigraciones.TabIndex = 7;
            this.tabSelectorConfigraciones.Text = "materialTabSelector2";
            // 
            // tabOpcConfiguraciones
            // 
            this.tabOpcConfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOpcConfiguraciones.Controls.Add(this.tabConfiguracionesUsuarios);
            this.tabOpcConfiguraciones.Controls.Add(this.tabConfiguracionesAccesos);
            this.tabOpcConfiguraciones.Controls.Add(this.tabConfiguracionesModulos);
            this.tabOpcConfiguraciones.Controls.Add(this.tabConfiguracionesParametros);
            this.tabOpcConfiguraciones.Depth = 0;
            this.tabOpcConfiguraciones.Location = new System.Drawing.Point(0, 54);
            this.tabOpcConfiguraciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcConfiguraciones.Multiline = true;
            this.tabOpcConfiguraciones.Name = "tabOpcConfiguraciones";
            this.tabOpcConfiguraciones.SelectedIndex = 0;
            this.tabOpcConfiguraciones.Size = new System.Drawing.Size(780, 277);
            this.tabOpcConfiguraciones.TabIndex = 6;
            // 
            // tabConfiguracionesUsuarios
            // 
            this.tabConfiguracionesUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionesUsuarios.Name = "tabConfiguracionesUsuarios";
            this.tabConfiguracionesUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracionesUsuarios.Size = new System.Drawing.Size(772, 251);
            this.tabConfiguracionesUsuarios.TabIndex = 0;
            this.tabConfiguracionesUsuarios.Text = "Usuarios";
            this.tabConfiguracionesUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionesAccesos
            // 
            this.tabConfiguracionesAccesos.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionesAccesos.Name = "tabConfiguracionesAccesos";
            this.tabConfiguracionesAccesos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracionesAccesos.Size = new System.Drawing.Size(772, 251);
            this.tabConfiguracionesAccesos.TabIndex = 1;
            this.tabConfiguracionesAccesos.Text = "Accesos";
            this.tabConfiguracionesAccesos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionesModulos
            // 
            this.tabConfiguracionesModulos.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionesModulos.Name = "tabConfiguracionesModulos";
            this.tabConfiguracionesModulos.Size = new System.Drawing.Size(772, 251);
            this.tabConfiguracionesModulos.TabIndex = 2;
            this.tabConfiguracionesModulos.Text = "Modulos";
            this.tabConfiguracionesModulos.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracionesParametros
            // 
            this.tabConfiguracionesParametros.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracionesParametros.Name = "tabConfiguracionesParametros";
            this.tabConfiguracionesParametros.Size = new System.Drawing.Size(772, 251);
            this.tabConfiguracionesParametros.TabIndex = 3;
            this.tabConfiguracionesParametros.Text = "Parametros";
            this.tabConfiguracionesParametros.UseVisualStyleBackColor = true;
            // 
            // imglistmenuprincipal
            // 
            this.imglistmenuprincipal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistmenuprincipal.ImageStream")));
            this.imglistmenuprincipal.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistmenuprincipal.Images.SetKeyName(0, "config.png");
            this.imglistmenuprincipal.Images.SetKeyName(1, "Monitor.png");
            this.imglistmenuprincipal.Images.SetKeyName(2, "mora.png");
            this.imglistmenuprincipal.Images.SetKeyName(3, "services.png");
            this.imglistmenuprincipal.Images.SetKeyName(4, "User.png");
            // 
            // mnustripmenuprincipal
            // 
            this.mnustripmenuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.morosidadToolStripMenuItem,
            this.configuracionesToolStripMenuItem});
            this.mnustripmenuprincipal.Location = new System.Drawing.Point(3, 64);
            this.mnustripmenuprincipal.Name = "mnustripmenuprincipal";
            this.mnustripmenuprincipal.Size = new System.Drawing.Size(951, 24);
            this.mnustripmenuprincipal.TabIndex = 1;
            this.mnustripmenuprincipal.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.preciosToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.registroToolStripMenuItem1.Text = "Registro";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.preciosToolStripMenuItem.Text = "Precios";
            // 
            // morosidadToolStripMenuItem
            // 
            this.morosidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMoraToolStripMenuItem,
            this.planesDePagoToolStripMenuItem,
            this.notificacionesToolStripMenuItem});
            this.morosidadToolStripMenuItem.Name = "morosidadToolStripMenuItem";
            this.morosidadToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.morosidadToolStripMenuItem.Text = "Morosidad";
            // 
            // listaMoraToolStripMenuItem
            // 
            this.listaMoraToolStripMenuItem.Name = "listaMoraToolStripMenuItem";
            this.listaMoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listaMoraToolStripMenuItem.Text = "Lista Mora";
            // 
            // planesDePagoToolStripMenuItem
            // 
            this.planesDePagoToolStripMenuItem.Name = "planesDePagoToolStripMenuItem";
            this.planesDePagoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.planesDePagoToolStripMenuItem.Text = "Planes de Pago";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.accesosToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // accesosToolStripMenuItem
            // 
            this.accesosToolStripMenuItem.Name = "accesosToolStripMenuItem";
            this.accesosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.accesosToolStripMenuItem.Text = "Accesos";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 590);
            this.Controls.Add(this.tabmenuprincipal);
            this.Controls.Add(this.mnustripmenuprincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabmenuprincipal;
            this.MainMenuStrip = this.mnustripmenuprincipal;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.tabmenuprincipal.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabOpcClientes.ResumeLayout(false);
            this.tabClientesRegistro.ResumeLayout(false);
            this.tabServicios.ResumeLayout(false);
            this.tabOpcServicios.ResumeLayout(false);
            this.tabMorosidad.ResumeLayout(false);
            this.tabOpcMorosidad.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabOpcConfiguraciones.ResumeLayout(false);
            this.mnustripmenuprincipal.ResumeLayout(false);
            this.mnustripmenuprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabmenuprincipal;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabServicios;
        private System.Windows.Forms.TabPage tabMorosidad;
        private System.Windows.Forms.TabPage tabConfiguraciones;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorClientes;
        private MaterialSkin.Controls.MaterialTabControl tabOpcClientes;
        private System.Windows.Forms.TabPage tabClientesRegistro;
        private System.Windows.Forms.TabPage tabClientesConsulta;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorServicios;
        private MaterialSkin.Controls.MaterialTabControl tabOpcServicios;
        private System.Windows.Forms.TabPage tabServiciosRegistro;
        private System.Windows.Forms.TabPage tabServicioConsulta;
        private System.Windows.Forms.TabPage tabServiciosPrecio;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMorocidad;
        private MaterialSkin.Controls.MaterialTabControl tabOpcMorosidad;
        private System.Windows.Forms.TabPage tabMorosidadListaMora;
        private System.Windows.Forms.TabPage tabMorosidadPlandePago;
        private System.Windows.Forms.TabPage tabMorosidadNotificaciones;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorConfigraciones;
        private MaterialSkin.Controls.MaterialTabControl tabOpcConfiguraciones;
        private System.Windows.Forms.TabPage tabConfiguracionesUsuarios;
        private System.Windows.Forms.TabPage tabConfiguracionesAccesos;
        private System.Windows.Forms.TabPage tabConfiguracionesModulos;
        private System.Windows.Forms.TabPage tabConfiguracionesParametros;
        private System.Windows.Forms.MenuStrip mnustripmenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morosidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaMoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ImageList imglistmenuprincipal;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}

